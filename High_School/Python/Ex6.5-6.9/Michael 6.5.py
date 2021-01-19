__author__ = 'Michael Spector'

import socket


def main():
    my_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    my_socket.sendto(b'Michael', ('54.213.229.251', 8821))
    (data, remote_address) = my_socket.recvfrom(1024)
    newd = data.decode('utf8')
    print('The server sent:' + str(newd))
    my_socket.close()


if __name__ == '__main__':
    main()
