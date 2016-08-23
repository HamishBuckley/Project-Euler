sum = 0
print("Find the sum of all the mutiples of 3 or 5 below ____")
for i in range(1, int(input())):
    if i % 5 == 0 or i % 3 == 0:
        sum += i
print (sum)
