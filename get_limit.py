import data_store

def get_limit():
    print(data_store.initial_object["overall_limit"])
    return data_store.initial_object["overall_limit"]

get_limit()