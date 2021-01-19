__author__ = 'Michael Spector'

import socket

DEST_PORT = 6501


def main():
    server_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    server_socket.bind(('0.0.0.0', DEST_PORT))
    (client_name, client_address) = server_socket.recvfrom(1024)
    server_socket.sendto(b'Hello ' + bytes(client_name), client_address)
    server_socket.close()


if __name__ == '__main__':
    main()
