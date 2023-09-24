class Car:
    def __init__(self, color, type1, year):
        self.color = color
        self.type = type1
        self.year = year
        self.indicator = 0
        self.indicator_stop = 1

    def start(self):
        if self.indicator == 1:
            print('Автомобиль уже заведен!')
        else:
            self.indicator = 1
            self.indicator_stop = 0
            print('Автомобиль заведен!')

    def stop(self):
        if self.indicator_stop == 1:
            print('Автомобиль уже заглушен!')
        else:
            self.indicator_stop = 1
            self.indicator = 0
            print('Автомобиль заглушен!')

    @property
    def year(self):
        return self.__year

    @year.setter
    def year(self, value):
        if value < 1886 or value > 2023:
            raise ValueError('Некорректное значение года')
        else:
            self.__year = value

    @property
    def type(self):
        return self.__type

    @type.setter
    def type(self, value):
        if isinstance(value, str):
            self.__type = value
        else:
            raise ValueError('Нет такого типа')

    @property
    def color(self):
        return self.__color

    @color.setter
    def color(self, value):
        if isinstance(value, str):
            self.__color = value
        else:
            raise ValueError('Нет такого цвета')

    def all_info(self):
        print(f'Год выпуска: {self.__year}')
        print(f'Тип: {self.__type}')
        print(f'Цвет: {self.__color}')

