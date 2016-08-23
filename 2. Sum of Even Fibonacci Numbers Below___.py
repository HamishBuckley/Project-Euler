def fibonacci(max):
    fiblist = [1,1]
    while True:
        if fiblist[-1] > max:
            break
        fiblist.append(fiblist[-1] + fiblist[-2])
        
    return fiblist
sum = 0
for i in fibonacci(4000000):
    if i % 2 == 0:
        sum += i
print (sum)
