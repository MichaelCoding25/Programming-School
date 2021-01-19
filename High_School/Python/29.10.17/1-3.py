__author__ = 'Michael'
###                 ###

import sys
import random

def main():
    num = 0
    user_num = 0
    n = 0
    num = random.randint(1, 20)
    print "Hello User!"
    print "I am thinking of a number between 1 and 20."
    while ((num != user_num) and (n < 6)):
        print"Take a guess:"
        user_num = input()
        n += 1
        if(user_num > num):
            print "Your guess is too high"
        elif (user_num < num):
            print "Your guess is too low"
    if (user_num == num):
        print ("Good job, you guessed the number correctly in " + str(n) + " guesses!")
    else:
        print "You weren't able to guess the number in 5 guesses."



if __name__ == '__main__':
    main()