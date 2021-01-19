__author__ = "Michael"
"""
Reads a list of users and stores it in memory. Until "" is entered login users or sign them up.
This program requires users_data.txt to be in the same directory and be empty
or follow the rules of (username,password\n...).
"""

LOGIN_FILE_PATH = r".\users_data.txt"
MIN_PASSWORD_LENGTH = 8


def login(users):
    """
    Ask for username and password and if they are in the list users, then return them.
    Otherwise, if the password is wrong, then login again, and if the
    username is wrong, then ask if they want to sign up, and if they do, then
    return the new user, and if they do not, then login again.
    If the username or the password is None return the username and password
    NOTE: REMEMBER TO UPDATE THE USERS_DATA FILE AFTER LOGIN!!!
    :param users: a list of strings where the password of a user is one index after it's username
    :return string: username; Can be None
    :return string: password; Can be None
    """
    print "Username: "
    username = raw_input()
    print "Password: "
    password = raw_input()

    if username != "" or password != "":
        if username in users[::2]:
            if password != users[2 * users[::2].index(username) + 1]:  # If the password is wrong
                print "Username taken or wrong password! Try again"
                username, password = login(users)
        else:
            print "Wrong username or new user!\nAre you a new user? (Y\\N)"
            if raw_input().lower() == 'y':  # If the user said yes
                username, password = signup(username, password, users)  # Return the new user
            else:
                print "Try again"
                # If the user exist but the information was wrong then login again
                username, password = login(users)
    return username, password


def signup(username, password, users):
    """
    Adds a user to the users list, but only after checking the password.
    NOTE: ONLY USE signup(username, password, users) IF NO OTHER USERNAME WITH THAT NAME
    EXISTS!!!
    :param username: A string to add as a username to users
    :param password: A string to add as a password to users
    :param users: a list of strings where the password of a user is one index after it's username
    :return username: the username chosen
    :return password: the password chosen
    """
    while len(password) < MIN_PASSWORD_LENGTH:
        print "The Password is too short. Minimum of " + str(MIN_PASSWORD_LENGTH) + " chars\nPassword:"
        password = raw_input()
    users.append(username)  # Add the username to the list of users
    users.append(password)  # Add the password to the list of users (after the username!!!)
    return username, password


def get_users_as_list(users_data):
    """
    Turns a string of "username,password\nusername,password\n..." to
    a list of strings like [username,password,username,password...].
    :param users_data: The string to turn to a list
    :return: A list of username and password
    """
    users = []
    users_data = users_data.split("\n")
    for line in users_data:
        users.append(line[:line.find(',')])
        users.append(line[line.find(',') + 1:])
    return users


def get_users_as_string(users_data):
    """
    Turns a list of strings like [username,password,username,password...] to
    a string of "username,password\nusername,password\n...".
    :param users_data: A list of username and password
    :return: A string of username and password
    """
    users = ""
    element_is_username = True
    for element in users_data[:-1]:
        if element_is_username:
            users += element + ','
        else:
            users += element + "\n"
        element_is_username = not element_is_username
    users += users_data[-1]
    return users


def main():
    with open(LOGIN_FILE_PATH, 'r') as users_data:  # Open the users data file in this directory
        users = get_users_as_list(users_data.read())  # Read the information of the users and turn it to a list

    username, password = login(users)
    while username is not "" and password is not "":
        with open(LOGIN_FILE_PATH, 'w') as users_data:
            print "Hello " + username + " your password is " + password
            users_data.write(get_users_as_string(users))
            username, password = login(users)
    with open(LOGIN_FILE_PATH, 'r') as users_data:  # Open the users data file in this directory
        print users_data.read()


if __name__ == "__main__":
    main()
