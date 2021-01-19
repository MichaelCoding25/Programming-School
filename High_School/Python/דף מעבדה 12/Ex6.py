__author__ = 'Michael'
###                 ###

import sys

def main():
    QUESTION_1 = "What year did the 2nd world war start?"
    ANSWER_1 = 1939
    QUESTION_2 = "What is the name of the 1st black president of the USA?"
    ANSWER_2 = "Barack Obama"
    QUESTION_3 = "Today is a very special day, ____"
    ANSWER_3 = "C"
    QUESTION_4 = "What is the color of the sun?"
    ANSWER_4 = "A"

    n = 0
    print "Welcome to the trivia game! Good Luck!"
    print ""
    print QUESTION_1
    user_answer = input()
    if (user_answer == ANSWER_1):
        print"It's the correct answer"
        n += 1
    else:
        print"Your answer is incorrect :("

    print ""
    print QUESTION_2
    user_answer = raw_input()
    if (user_answer == ANSWER_2):
        print"It's the correct answer"
        n += 1
    else:
        print"Your answer is incorrect :("

    print ""
    print QUESTION_3
    print "A) it's very special."
    print "B) so special that..."
    print "C) how special is it?"
    print "D) it's not special."
    user_answer = raw_input()
    if (user_answer == ANSWER_3):
        print"It's the correct answer"
        n += 1
    else:
        print"Your answer is incorrect :("

    print ""
    print QUESTION_4
    print "A) Yellow"
    print "B) Red"
    print "C) Green"
    print "D) Blue"
    user_answer = raw_input()
    if (user_answer == ANSWER_4):
        print"It's the correct answer"
        n += 1
    else:
        print"Your answer is incorrect :("
    if (n == 4):
        print "You answered all of the questions correctly!"
    else:
        print ("You answered " + str(n) + " questions correctly.")



if __name__ == '__main__':
    main()