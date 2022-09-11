initial_object = {
    "water_sources": [{
        "area": "laundry",
        "tap": 2,
        "washing_machine": 10,
    }, {
        "area": "kitchen",
        "dish_washer": 1,
        "ice_machine": 1,
    }, {
        "area": "bathroom",
        "toilet": 2,
        "shower": 6,
        "sink": 3,
    }, {
        "area": "ensuite_bathroom",
        "toilet": 1,
        "shower": 7,
        "sink": 2,
    }],
    "overall_limit": 300,
}


'''class Datastore:
    def __init__(self):
        self.__store = initial_object

    def get(self):
        return self.__store

    def set(self, store):
        if not isinstance(store, dict):
            raise TypeError('store must be of type dictionary')
        self.__store = store



global data_store
data_store = Datastore()

print(data_store)'''