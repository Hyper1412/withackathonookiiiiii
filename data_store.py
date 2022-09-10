initial_object = {
    "water_sources": [{
        "area": "laundry",
        "tap": 0,
        "washing_machine": 0,
    }, {
        "area": "kitchen",
        "dish_washer": 0,
        "ice_machine": 0,
    }, {
        "area": "bathroom",
        "toilet": 0,
        "shower": 0,
        "sink": 0,
    }, {
        "area": "ensuite_bathroom",
        "toilet": 0,
        "shower": 0,
        "sink": 0,
    }],
    "overall_limit": None,
    "price_kl": 2.35,
}


class Datastore:
    def __init__(self):
        self.__store = initial_object

    def get(self):
        return self.__store

    def set(self, store):
        if not isinstance(store, dict):
            raise TypeError('store must be of type dictionary')
        self.__store = store

print('Loading Datastore...')

global data_store
data_store = Datastore()
