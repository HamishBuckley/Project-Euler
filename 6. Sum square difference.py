print("Find the difference between the sum of the squares of the first 'n' natural numbers and the square of the sum of the first 'n' natural numbers")
print("what number do you want 'n' to be")
i = int(input())
sumsquares = 0
for j in range(1,i +1):
    sumsquares += j **2
print("The sum of the squares is {}".format(sumsquares))
sumrange =0
for k in range(1,i+1):
    sumrange += k
sumrange = sumrange **2
print("The square of the sum is {}".format(sumrange))
print("The diffrence is {}".format(sumrange - sumsquares)) 
print("")
print("press 'enter' to exit")
input()
