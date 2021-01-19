factorial = 1
print "Enter a number between 10 and 1000:"
num = input()
while num >= 10:
    if num%7==0:
        if num%2==0:
            print "Even"
        else:
            print "Odd"
    elif num%5==0:
        if num%2==0:
            print "Even"
        else:
            print "Odd"
    elif num%3==0:
        if num%2==0:
            print "Even"
        else:
            print "Odd"
    elif num%2==0:
        if num%2==0:
            print "Even"
        else:
            print "Odd"
    else:
        while (num>0):
            factorial=factorial*num
            num=num-1
        print ("The factorial of the number is:")
        print (factorial)
    print "Enter a number between 10 and 1000:"
    num = input()
     
        
        
