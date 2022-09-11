import data_store

def increase_usage():
    water_increase = data_store.initial_object["water_sources"][0]
    water_increase["shower"] = water_increase["shower"] + 3
    water_increase["toilet"] = water_increase["toilet"] + 1
    water_increase["sink"] = water_increase["sink"] + 2
    return
