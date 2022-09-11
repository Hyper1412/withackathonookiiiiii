import data_store

def get_area_water_usage(area):
    total = 0
    water_sources = data_store.initial_object["water_sources"]
    for source in water_sources:
        if source["area"] == area:
            for key in source:
                if isinstance(source[key], str):
                    continue
                total += source[key]
    print(total)
    return total