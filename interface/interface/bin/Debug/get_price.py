import calc_total_water_usage
from data_store import Datastore

store = Datastore.get()

def get_price():
    # might gotta convert price to per litre
    water_used = calc_total_water_usage()

    return store["price_kl"] * water_used