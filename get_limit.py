import data_store

store = data_store.get()

def get_limit():
    return store["users"][0]["overall_limit"]