__author__ = 'Michael'
###                 ###

import sys

def main():
   sum = 0
   n = 0
   grade = 0
   average = 0
   print "Enter the grades in the test, if you want to stop entering grades enter -1:"
   grade = input()
   while ((grade > -1)):
       if(grade > 100):
           print "You entered a number higher then 100, it's impossible!"
           raw_input()
           sys.exit()
       else:
           n += 1
           sum = (grade + sum)
           grade = input()
   print ("The sum of the grades is: " + str(sum))
   average = (sum / float(n))
   print ("The average of the grades is: " + str(average))




if __name__ == '__main__':
    main()