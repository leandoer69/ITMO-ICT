class Soda:
    def __init__(self, type_of_water):
        self.type_of_water = type_of_water

    @property
    def type_of_water(self):
        return self.__type_of_water

    @type_of_water.setter
    def type_of_water(self, new_type):
        self.__type_of_water = new_type


    def show_my_drink(self):
        print(f'Газировка {self.__type_of_water}')

print('Введите вид газика:')
type = input()
m1 = Soda(type)
m1.show_my_drink()
print('Фууууу, не пейте это, выпейте лучше спрайт!')
m1.type_of_water = 'Спрайт'
m1.show_my_drink()