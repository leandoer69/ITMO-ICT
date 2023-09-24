class Dog:
    name = None
    age = None

    def get_name(self):
        return self.name

    def set_name(self, value):
        if isinstance(value, str):
            self.name = value
        else:
            raise ValueError('Ошибка ввода')

    def get_age(self):
        return self.age

    def set_age(self, value):
        if isinstance(value, int) and 0 < value < 20:
            self.age = value
        else:
            raise ValueError('Ошибка ввода')


class ToyTerrier(Dog):
    sound_of_voice = 'Писк'
    prednazn = 'Домашняя'
    name = 'Bob'
    age = 15

class Spaniele(Dog):
    sound_of_voice = 'Громкий'
    prednazn = 'Сторожевая'
    name = 'Alex'
    age = 9

class DeutchOvch(Dog):
    sound_of_voice = 'Тихий'
    prednazn = 'Охотничья'
    name = 'Sharik'
    age = 17

d1 = ToyTerrier()
d2 = Spaniele()
d3 = DeutchOvch()

print(d1.prednazn, d1.name)
print(d2.prednazn, d2.name)
print(d3.prednazn, d3.name)
d1.set_age(16)
print(d1.age)
