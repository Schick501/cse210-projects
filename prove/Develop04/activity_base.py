import time
import sys

class Activity:
    def __init__(self, name, description):
        self.name = name
        self.description = description
        self.duration = 0

    def get_duration(self):
        while True:
            try:
                self.duration = int(input("Enter the duration in seconds: "))
                if self.duration > 0:
                    break
                else:
                    print("Please enter a positive number.")
            except ValueError:
                print("Invalid input. Please enter a valid number.")

    def start_message(self):
        print(f"\nStarting {self.name}...")
        print(self.description)
        self.get_duration()
        print("Prepare to begin...")
        self.show_animation(3)

    def end_message(self):
        print("\nGood job! You have completed the activity.")
        print(f"You just completed '{self.name}' for {self.duration} seconds.")
        self.show_animation(3)

    def show_animation(self, seconds):
        for i in range(seconds, 0, -1):
            sys.stdout.write(f"\r{i} ")
            sys.stdout.flush()
            time.sleep(1)
        print("\n")

    def run(self):
        raise NotImplementedError("This method should be implemented by subclasses.")
