import time
import sys
from activity_base import Activity

class BreathingActivity(Activity):
    def __init__(self):
        super().__init__("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")

    def run(self):
        self.start_message()
        for _ in range(self.duration // 6):
            print("Breathe in...")
            self.show_animation(3)
            print("Breathe out...")
            self.show_animation(3)
        self.end_message()
