import data_store

store = data_store.get()

def get_area_water_usage(area):
    total = 0
    water_sources = store["water_sources"]
    for source in water_sources:
        if soure["area"] == area:
            for key in source:
                if isinstance(source[key], str):
                    continue
                total += source[key]

    return total