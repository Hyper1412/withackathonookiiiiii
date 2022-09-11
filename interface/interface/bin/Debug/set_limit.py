from data_store import Datastore

store = Datastore.get()

def set_limit(limit):
    store["overall_limit"] = int(limit)
    Datastore.set(store)
    return
