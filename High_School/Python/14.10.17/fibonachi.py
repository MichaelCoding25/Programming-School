a, b = 0, 1
print (a)
for i in range(100):
    print (b)
    a, b = b, a+b
    i = i + 1
