
def DivisibleByRange(beg, end, inputnumber):
    for i in (range(beg, end)):
        if inputnumber % i != 0:

            return False
    return True
beg = int(input())
end = int(input())
n = 1
while True:
    if DivisibleByRange( beg, end, n):
        print(n)
        break
    n += 1
