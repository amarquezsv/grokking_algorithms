def binary_search(arr, item):
    # Low and high keep track of wich par of the list you'll search in.
    low = 0
    high = len(arr)-1

    while low <= high:
        mid = (low + high) // 2     # check the middle element
        guess = arr[mid]
        if guess == item:
            return mid
        elif guess > item:          # The guess was to hig
            high = mid -1
        else:
            low = mid + 1           # The guess was too low
    return None                     # The item doesn't exist

my_list = list(range(6, 2500))

print(binary_search(my_list, 9))
print(binary_search(my_list, 2000))
print(binary_search(my_list, 3))