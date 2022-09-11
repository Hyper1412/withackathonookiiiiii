import calc_total_water_usage
from data_store import Datastore

store = Datastore.get()

def lake():
    water_used = calc_total_water_usage()
    water_left = store["overall_limit"] - water_used
    return water_left / store["overall_limit"]

