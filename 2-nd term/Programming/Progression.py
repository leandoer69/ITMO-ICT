class Progression:
    def __init__(self, type, start, razn):
        self.type = type
        self.start = start
        self.razn = razn

    def arifm(self, number):
        for i in range(1, number + 1):
            print(self.start + razn * (i - 1), end = ' ')


    def geom(self, number):
        for i in range(1, number + 1):
            print(self.start * self.razn ** (i - 1), end = ' ')



print('Укажите первый член и разность прогрессии:')
first, razn = map(int, input().split())
print('Укажите вид прогресии: а или г')
type = input()
print('Укажите номер члена, до которого хотите получить:')
n = int(input())

if type == 'а':
    pr = Progression(type, first, razn)
    pr.arifm(n)
if type == 'г':
    pr = Progression(type, first, razn)
    pr.geom(n)
