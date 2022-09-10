import calc_total_water_usage
import data_store

store = data_store.get()

def lake():
    water_used = calc_total_water_usage()
    water_left = store["overall_limit"] - water_used
    return water_left / store["overall_limit"]

