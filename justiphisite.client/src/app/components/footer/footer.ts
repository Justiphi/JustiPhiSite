import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { siteConfig } from '../../site-config';

@Component({
  selector: 'app-footer',
  imports: [RouterLink],
  templateUrl: './footer.html',
  styleUrl: './footer.css',
})
export class Footer {
  protected readonly site = siteConfig;
  protected readonly year = new Date().getFullYear();
}
