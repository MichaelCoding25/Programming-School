# Author: Michael Spector

import socket
import os
import traceback

PORT = 8080
SOCKET_TIMEOUT = 30
DEFAULT_URL = 'localhost:' + str(PORT)
WEBROOT_PATH = r'C:/Users/mikis/OneDrive/שולחן העבודה/webroot'
FORBIDDEN_FILES = [r'C:/Users/mikis/OneDrive/שולחן העבודה/webroot/top_secret.txt',
                   r'C:/Users/mikis/OneDrive/שולחן העבודה/webroot/imgs/secret_cat.jpg']


def get_file_data(filename):
    """ Get data from file """
    with open(filename, 'rb') as content_file:
        contents = content_file.read()
    return contents


def handle_client_request(resource, client_socket):
    """ Check the required resource, generate proper HTTP response and send to client"""
    s = list(resource)
    resource = "".join(s)
    filename = WEBROOT_PATH + resource[resource.find(r'/'):]
    if resource.find('/') == len(resource) - 1:
        resource += 'index.html'
        filename += 'index.html'
    if not os.path.isfile(filename):
        client_socket.send(b'HTTP/1.1 404 Not Found\r\n')
        client_socket.close()
        return
    if filename in FORBIDDEN_FILES:
        client_socket.send(b'HTTP/1.1 403 Forbidden\r\n')
        client_socket.close()
        return

    file_type = resource[resource.rfind('.') + 1:]
    if file_type == 'html':
        http_header = b"Content-Type: text/html; charset=utf-8 \r\n\r\n"
    elif file_type == 'jpg':
        http_header = b"Content-Type: image/jpeg\r\n\r\n"
    elif file_type == 'js':
        http_header = b"Content-Type: text/javascript; charset=UTF-8\r\n\r\n"
    elif file_type == 'css':
        http_header = b"Content-Type: text/css\r\n\r\n"
    else:
        http_header = b''

    data = get_file_data(filename)
    first_line = b'HTTP/1.1' + b' 200 OK' + b'\r\n'
    length_line = b'Content-Length: ' + str(len(data)).encode() + b'\r\n'
    http_response = first_line + length_line + http_header + data
    client_socket.send(http_response)


def validate_http_request(request):
    """ Check if request is a valid HTTP request and returns TRUE / FALSE and the requested URL """
    if request == '':
        return False, ''
    all_lines = request.split('\r\n')
    first_line_words = all_lines[0].split(' ')
    if all_lines[0].startswith('GET') and all_lines[0].endswith('HTTP/1.1'):
        return True, first_line_words[1]
    return False, first_line_words[1]


def handle_client(client_socket):
    """ Handles client requests: verifies client's requests are legal HTTP, calls function to handle the requests """
    print('Client connected')
    client_request = b''
    while not client_request.endswith(b'\r\n\r\n'):
        byte = client_socket.recv(1)
        if byte == b'':
            raise ConnectionError("Client crashed")
        client_request += byte
    client_request = client_request.decode()
    valid_http, resource = validate_http_request(client_request)
    if valid_http:
        print('Got a valid HTTP request')
        handle_client_request(resource, client_socket)
    else:
        print('Error: Not a valid HTTP request')

    print('Closing connection')
    client_socket.close()


def main():
    server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server_socket.bind(('0.0.0.0', PORT))
    server_socket.listen(1)
    print("Listening for connections on port %d" % PORT)

    while True:
        try:
            client_socket, client_address = server_socket.accept()
            print('New connection received')
            handle_client(client_socket)
        except socket.timeout:
            print("Time ran out, server closed")
        except ConnectionError:
            traceback.print_exc()


if __name__ == "__main__":
    main()
