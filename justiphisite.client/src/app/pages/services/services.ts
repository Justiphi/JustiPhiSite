import { Component, OnInit, inject, signal } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { ServiceApi, ServiceCategory, categorySlug } from '../../data/service-api';
import { siteConfig } from '../../site-config';

@Component({
  selector: 'app-services',
  imports: [RouterLink],
  templateUrl: './services.html',
  styleUrl: './services.css',
})
export class Services implements OnInit {
  private readonly api = inject(ServiceApi);
  private readonly route = inject(ActivatedRoute);

  protected readonly categories = signal<ServiceCategory[] | null>(null);
  protected readonly failed = signal(false);
  protected readonly slug = categorySlug;
  protected readonly site = siteConfig;

  ngOnInit() {
    this.api.getCategories().subscribe({
      next: (result) => {
        this.categories.set(result);
        this.scrollToFragment();
      },
      error: (error) => {
        console.error(error);
        this.failed.set(true);
      },
    });
  }

  // The router tries to scroll to the fragment before the sections exist, so retry once they've rendered.
  private scrollToFragment() {
    const fragment = this.route.snapshot.fragment;
    if (!fragment) {
      return;
    }
    setTimeout(() => document.getElementById(fragment)?.scrollIntoView());
  }
}
