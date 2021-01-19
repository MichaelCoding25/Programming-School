__author__ = 'Michael Spector'
"""This program is the client side of the system.
It waits for 1 of 4 commands to be put in, and ones it receives one, it sends it to the server, and waits for the
response and prints it"""


import socket

BYTE_RECEIVE_SIZE = 4


def main():
    my_socket = socket.socket()
    try:
        my_socket.connect(('127.0.0.1', 1729))
    except socket.error:
        print('Could not connect to server, try again later.')
        my_socket.close()
        return

    user_input = input('Input command:')
    user_input = user_input.upper()
    try:
        while True:
            if user_input == 'TIME' or user_input == 'NAME' or user_input == 'RAND' or user_input == 'EXIT':
                b = user_input.encode('utf-8')
                my_socket.send(b)
                if user_input == 'EXIT':
                    print('Bye bye')
                    return

                byte_inputs = str(my_socket.recv(BYTE_RECEIVE_SIZE), "utf-8")
                index = 0
                for digit in byte_inputs:
                    if digit == 0:
                        index += 1
                    else:
                        break
                byte_inputs = byte_inputs[index:]
                print(str(my_socket.recv(int(byte_inputs)), "utf-8"))
            else:
                print('Input Error')
            print('Input command:')
            user_input = input()
    except socket.error:
        print('Server disconnected, try again later')
        my_socket.close()


if __name__ == '__main__':
    main()
