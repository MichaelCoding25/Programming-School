__author__ = 'Michael Spector'

import socket

NAME = 'Michael'
DEST_PORT = 6501


def main():
    my_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    my_socket.sendto(bytes(NAME), ('127.0.0.1', DEST_PORT))
    (data, remote_address) = my_socket.recvfrom(1024)
    newd = data.decode('utf8')
    print(str(newd))
    my_socket.close()


if __name__ == '__main__':
    main()
