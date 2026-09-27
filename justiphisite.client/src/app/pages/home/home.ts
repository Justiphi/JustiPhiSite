import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

interface Offering {
  title: string;
  fragment: string;
  summary: string;
  items: string[];
}

@Component({
  selector: 'app-home',
  imports: [RouterLink],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  protected readonly offerings: Offering[] = [
    {
      title: '3D Printing',
      fragment: '3d-printing',
      summary: 'From tough functional parts to finely detailed resin models, designed and printed to order.',
      items: ['FDM and resin printing', '3D modelling and prototyping', 'Printer maintenance and repair'],
    },
    {
      title: 'IT Support',
      fragment: 'it-support',
      summary: 'Friendly, jargon-free help keeping your computers and network running smoothly.',
      items: ['Desktop PC repair and upgrades', 'Virus and malware removal', 'Networking and data recovery'],
    },
    {
      title: 'Software Development',
      fragment: 'software-development',
      summary: 'Websites and custom tools that save you time and fit the way you actually work.',
      items: ['Websites and web apps', 'Custom software and automation', 'Database design'],
    },
  ];

  protected readonly steps = [
    { title: 'Tell me what you need', text: 'Send a short message describing the job, with any files, photos or measurements you have.' },
    { title: 'Get a clear quote', text: "I'll come back with a quote and timeframe, with no obligation to go ahead." },
    { title: 'Get it done', text: "Once you're happy, I get to work and keep you updated until the job is finished." },
  ];
}
