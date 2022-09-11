import calc_total_water_usage
import data_store

def lake():
    water_used = calc_total_water_usage()
    water_left = data_store.initial_object["overall_limit"] - water_used
    percent = water_left / data_store.initial_object["overall_limit"]
    print(percent)

    return

lake()