__author__='Michael Spector'
##                     ##

import sys

def Encrypt(word):
    """Encrypts word
    Args:
        woed - a string
    """
    Encrypted = word[-2:] + word[:-2] + "ba"
    return Encrypted

def main():
    print "Please enter a word with at least 4 characters:"
    user_input = raw_input()
    while(len(user_input) < 4):
        print "Please enter a word with at least 4 characters:"
        user_input = raw_input()
    output = Encrypt(user_input)

    print ("The encrypted word is: " + output)




if __name__ == '__main__':
    main()