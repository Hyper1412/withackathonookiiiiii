import data_store

store = data_store.get()

def calc_total_water_usage():
    total = 0
    water_sources = store["water_sources"]
    for source in water_sources:
        for key in source:
            if isinstance(source[key], str):
                continue
            total += source[key]

    return total