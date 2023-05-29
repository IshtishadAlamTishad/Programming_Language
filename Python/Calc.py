a = input("Enter first number : ")
b = input("Enter second number : ")

c = input("Enter operation Character : ")


def add(x,y):
    return float (x)+float (y)

def sub(x,y):
    return float (x)- float (y)

def mul(x,y):
    return float (x) * float (y)

def div(x,y):
    return float (x)/ float (y)

if c=='+':
 print(add(a,b))
elif c=='-':
    print(sub(a,b))
elif c== '*':
        print(mul(a,b))
elif c=='/' :
 print(div(a,b))


fruits = ["apple","banana","guava"]
for x in fruits:
    if x=="guava":
        continue
    print(x)
