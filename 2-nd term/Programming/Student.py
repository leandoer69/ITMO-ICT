class Student:
    def __init__(self, name = 'Radomir', groupNumber = 1213, age = 18):
        self.name = name
        self.groupNumber = groupNumber
        self.age = age

    @property
    def name(self):
        return self.__name

    @name.setter
    def name(self, value):
        if isinstance(value, str):
            self.__name = value
        else:
            raise ValueError('Некорректный ввод')

    @property
    def groupNumber(self):
        return self.__groupNumber

    @groupNumber.setter
    def groupNumber(self, value):
        if isinstance(value, int):
            self.__groupNumber = value
        else:
            raise ValueError('Некорректный ввод')

    @property
    def age(self):
        return self.__age

    @age.setter
    def age(self, value):
        if isinstance(value, int):
            self.__age = value
        else:
            raise ValueError('Некорректный ввод')


Radomir = Student()
Vladimir = Student('Vladimir', 3123, 19)
Olga = Student('Olga', 1234)
Semen = Student('Semen', 1213, 27)
Victor = Student('Victor', 1441, 13)

print(Vladimir.name)
print(Radomir.name)
print(Olga.age)
print(Victor.groupNumber)