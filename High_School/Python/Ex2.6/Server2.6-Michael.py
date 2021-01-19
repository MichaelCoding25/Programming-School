__author__ = 'Michael Spector'
"""This is the server side of the system.
It listens to a connection constantly and when it connect to a client,
it waits for 1 of 4 commands to be sent to it, and generates and sends back
the appropriate response."""


import socket
import datetime
import random


NAME = 'Best Server'
BYTE_RECEIVE_SIZE = 4


def time(client_socket):
    """:param - receives the socket that contains the link to the client
       When this function is accessed, it takes the current time of the system and sends it to the client."""
    current_time = str(datetime.datetime.time(datetime.datetime.now()))
    current_time = current_time[:5]
    client_socket.send(str(len(current_time)).encode('utf-8'))
    client_socket.send(current_time.encode('utf-8'))


def name(client_socket):
    """:param - receives the socket that contains the link to the client
       When this function is accessed, it takes the name of the server, and sends it to the client."""
    client_socket.send(str(len(NAME)).encode('utf-8'))
    client_socket.send(NAME.encode('utf-8'))


def rand(client_socket):
    """:param - receives the socket that contains the link to the client
       When this function is accessed, it creates a random number between 1 and 10, and sends it to the client"""
    num = random.randint(1, 11)
    client_socket.send(str(len(str(num))).encode('utf-8'))
    client_socket.send(str(num).encode('utf-8'))


def exit_program(client_socket, server_socket):
    """param - receives the socket that contains the link to the client, and receives the
    socket thar contains the link to the server.

    When this function is accessed, it closes both the client and the server socket, and by that stopping
     the server."""
    client_socket.close()
    server_socket.close()


def main():
    try:
        server_socket = socket.socket()
        server_socket.bind(('0.0.0.0', 1729))
        server_socket.listen(1)
        client_socket, address = server_socket.accept()

        while True:
            user_input = str(client_socket.recv(BYTE_RECEIVE_SIZE), "utf-8")
            print(user_input)
            if user_input == 'TIME':
                time(client_socket)
            elif user_input == 'NAME':
                name(client_socket)
            elif user_input == 'RAND':
                rand(client_socket)
            elif user_input == 'EXIT':
                exit_program(client_socket, server_socket)
    except socket.error or ConnectionError:
        print('Client disconnected, Server closed.')


if __name__ == '__main__':
    main()
