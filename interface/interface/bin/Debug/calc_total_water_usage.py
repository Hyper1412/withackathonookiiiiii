import data_store

def calc_total_water_usage():
    total = 0
    water_sources = data_store.initial_object["water_sources"]
    for source in water_sources:
        for key in source:
            if isinstance(source[key], int):
                total += source[key]

    print(total)
    return total

calc_total_water_usage()