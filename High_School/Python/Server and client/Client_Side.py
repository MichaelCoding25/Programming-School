import socket


my_socket = socket.socket()
my_socket.connect(('127.0.0.1', 1729))

print(str(my_socket.recv(1024), "utf-8"))
name = input()
b = str.encode(name)
my_socket.send(b)
print(str(my_socket.recv(1024), "utf-8"))


my_socket.close()
