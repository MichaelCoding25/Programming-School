import sys

total = 0
print "Enter a number:"
num = raw_input()
while int(num) > 0:
    evenOdd = int(num) % 2
    if evenOdd == 0:
        print "The number is even"
        total = total + int(num)
        
    else:
        print "The number is odd"
        total = total + int(num)
        
    print "Enter a number:"
    num = raw_input()
    
print ("The total of the positive numbers you wrote is: " + str(total))
    
    
