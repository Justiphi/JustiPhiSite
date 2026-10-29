import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { siteConfig } from '../../site-config';

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
  protected readonly site = siteConfig;

  // IT Support and Software Development are temporarily hidden while the site focuses on 3D printing.
  protected readonly offerings: Offering[] = [
    {
      title: 'Software Solutions',
      fragment: 'software-solutions',
      summary: 'Software that solves real problems for people running 3D printers.',
      items: ['Layer Zero printer maintenance tracking', 'Maintenance schedules and reminders', 'Spare part inventory'],
    },
    {
      title: '3D Printing',
      fragment: '3d-printing',
      summary: 'From tough functional parts to finely detailed resin models, designed and printed to order.',
      items: ['FDM and resin printing', '3D modelling and prototyping', 'Printer maintenance and repair'],
    },
  ];

  protected readonly steps = [
    { title: 'Tell me what you need', text: 'Send a short message describing the job, with any files, photos or measurements you have.' },
    { title: 'Get a clear quote', text: "I'll come back with a quote and timeframe, with no obligation to go ahead." },
    { title: 'Get it done', text: "Once you're happy, I get to work and keep you updated until the job is finished." },
  ];
}
