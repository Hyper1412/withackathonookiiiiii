from data_store import Datastore

store = Datastore.get()

def get_limit():
    print(store["overall_limit"])
    return store["overall_limit"]