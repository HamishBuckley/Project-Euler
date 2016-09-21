def DivisiblityChecker(beg, end, inputnumber):
    for i in (range(beg, end)):
        if inputnumber % i != 0:
            return False
    return True

def DivisiblityRangeFinder( beg, end, n):
    increamenter = n
    while True:
        if DivisiblityChecker( beg, end, n):
            return(n)
        n += increamenter
        
print("This is a tool for finding the smallest positive number that is evenly divisible by all of the numbers in a range")
print("what is the smallest number in your range")
beg = int(input())
print("what is the biggest number in your range")
end = int(input()) + 1
n = 1
range_increacer = beg + 1

while True:
    #We find the smallest positive number that is evenly divisible by our range.
    #then we use this number as "n" to find the smallest number of the next range
    n = DivisiblityRangeFinder( beg, range_increacer, n) 
    if range_increacer == end:
        print("the smallest positive number that is evenly divisible by {0}-{1} is".format(beg, end -1))
        print(n)
        break
    range_increacer +=1
print("press any key to exit")
input()

    

