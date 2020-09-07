import socket


server_socket = socket.socket()
server_socket.bind(('0.0.0.0', 1729))
server_socket.listen(1)

client_socket, address = server_socket.accept()

client_socket.send(b"Welcome client, please enter your name:")
name = str(client_socket.recv(1024), "utf-8")
full_str = "Hi " + str(name) + ", nice to meet you."
b = full_str.encode('utf-8')
client_socket.send(b)

client_socket.close()
server_socket.close()
