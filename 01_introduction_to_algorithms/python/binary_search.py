import time;

def binary_search(array, item):
    # low and high keep track of which part of the list you're searching
    low = 0 
    high = len(array) - 1 
    
    # while you haven't narrowed it down to one element yet
    while low <= high:
        # round down the middle index
        middle = (low + high) // 2
        guess = array[middle] 
        
        # if you've found the item, return its index
        if guess == item: 
            return middle
          
        # if the guess was too high, adjust the high to middle - 1
        if guess > item:
            high = middle - 1 
        # if the guess was too low, adjust the low to middle + 1
        else: 
            low = middle + 1 
    
    # if the item is not found in the array, return None
    return None

my_array = [1, 2, 3, 4, 5, 6, 7, 8]

start_time = time.time()
print(binary_search(my_array, 8))
execution_time = time.time() - start_time

print(f"--- {execution_time:.6f} segundos ---")