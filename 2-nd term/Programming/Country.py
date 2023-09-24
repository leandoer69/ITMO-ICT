class Country:
    capital = None
    population = None

    def get_population(self):
        return self.population

    def set_population(self, value):
        if isinstance(value, int) and value > 0:
            self.population = value
        else:
            raise ValueError('Некорректный ввод')

class Russia(Country):
    capital = 'Moscow'
    population = 150000000



class Canada(Country):
    capital = 'Ottava'
    population = 70000000



class Germany(Country):
    capital = 'Berlin'
    population = 80000000




c1 = Russia()
c2 = Germany()
c3 = Canada()

print(c1.get_population())
print(c2.get_population())
print(c3.get_population())

c1.set_population(13333)
c2.set_population(54535346)
c3.set_population(34)

print(c1.get_population())
print(c1.capital)
print(c3.get_population())