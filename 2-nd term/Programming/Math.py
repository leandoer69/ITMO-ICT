
class Math:
    def __init__(self, a, b):
        self.a = a
        self.b = b

    def addition(self):
        print(self.a + self.b)

    def multiplication(self):
        print(self.a * self.b)

    def division(self):
        if self.b == 0:
            print('Нельзя делить на 0')
        else:
            print(self.a / self.b)

    def substraction(self):
        print(self.a - self.b)

print('Введите числа:')
a, b = map(int,input().split())
m = Math(a,b)
print('Что хотите сделать?')
print('1 - сложить')
print('2 - умножить')
print('3 - поделить')
print('4 - вычесть')
n = int(input())

if n == 1:
    m.addition()
if n == 2:
    m.multiplication()
if n == 3:
    m.division()
if m == 4:
    m.substraction()
