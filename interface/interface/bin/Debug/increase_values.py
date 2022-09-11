from data_store import Datastore

store = Datastore.get()

def increase_usage():
    water_increase = store["water_sources"][0]
    water_increase["shower"] = water_increase["shower"] + 3
    water_increase["toilet"] = water_increase["toilet"] + 1
    water_increase["sink"] = water_increase["sink"] + 2
    Datastore.set(store)
    return
