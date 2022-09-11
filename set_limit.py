import data_store

def set_limit(limit):
    data_store.inital_object["overall_limit"] = int(limit)
    return
