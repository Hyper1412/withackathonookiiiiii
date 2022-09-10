import data_store

store = data_store.get()

def set_limit(limit):
    user = store["users"][0]
    user["individual_limit"] = 10
    return {user["individual_limit"]}
