import time
import random
from activity_base import Activity

class ListingActivity(Activity):
    def __init__(self):
        super().__init__("Listing Activity", "This activity will help you reflect on good things in your life by listing them.")
        self.prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ]

    def run(self):
        self.start_message()
        print(random.choice(self.prompts))
        self.show_animation(3)
        print("Start listing your responses:")
        start_time = time.time()
        responses = []
        while time.time() - start_time < self.duration:
            response = input(" > ")
            responses.append(response)
        print(f"\nYou listed {len(responses)} items!")
        self.end_message()
