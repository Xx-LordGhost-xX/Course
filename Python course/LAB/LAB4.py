dict_names = {"ghost": 25000, "adi": 30000, "yakir": 76000, "ortal": 66000, "gal": 120000}
print(dict_names)
summay = dict_names["ghost"] + dict_names["gal"]
print("The summary is: " + str(summay))
dict_names.update({"yoel": summay})
print(dict_names)
print("Number of entries: " + str(len(dict_names)))
print("adi" in dict_names)
