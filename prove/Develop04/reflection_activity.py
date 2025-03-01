import time
import random
from activity_base import Activity

class ReflectionActivity(Activity):
    def __init__(self):
        super().__init__("Reflection Activity", "This activity helps you reflect on your strength and resilience.")
        self.prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ]
        self.questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ]

    def run(self):
        self.start_message()
        print(random.choice(self.prompts))
        time.sleep(3)
        start_time = time.time()
        while time.time() - start_time < self.duration:
            print(random.choice(self.questions))
            self.show_animation(5)
        self.end_message()
