import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-about',
  imports: [RouterLink],
  templateUrl: './about.html',
  styleUrl: './about.css',
})
export class About {
  protected readonly values = [
    { title: 'Clear quotes', text: "You'll know the cost and timeframe up front, before any work begins." },
    { title: 'Plain English', text: 'No jargon. I explain the options so you can make an informed decision.' },
    { title: 'Done properly', text: 'Work is tested and checked before it reaches you, and I stand behind it.' },
  ];
}
