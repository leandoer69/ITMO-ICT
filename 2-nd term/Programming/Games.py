class Games:
    year = None

    def get_year(self):
        return self.year

    def set_year(self, value):
        if isinstance(value, int):
            self.year = value
        else:
            raise ValueError('Ошибка ввода')


    def get_name(self):
        return self.__name


class PCGames(Games):
    name = 'Шрек 2: Война ослов'
    year = 2002
    os = 'Linux'
    def get_name(self):
        return f'Игра на компьютер {self.__name}'


class PS4Games(Games):
    name = 'Барби 3D'
    year = 2006
    cost = 999
    def get_name(self):
        return f'Игра на PS {self.__name}'

class XboxGames(Games):
    name = 'Симулятор студента ИТМО'
    year = 2019
    janr = 'fantazy'
    def get_name(self):
        return f'Игра на Xbox {self.__name}'


class MobileGames(Games):
    name = 'Нарды'
    year = 1999
    telephone = 'Iphone'
    def get_name(self):
        return f'Игра на компьютер {self.__name}'


g1 = PCGames()
g2 = PS4Games()
g3 = XboxGames()
g4 = MobileGames()

print(g1.name, g1.year, g1.os)
print(g2.name, g2.year, g2.cost)
print(g3.name, g3.year, g3.janr)
print(g4.name, g4.year, g4.telephone)

g1.set_year(2005)
print(g1.year)
