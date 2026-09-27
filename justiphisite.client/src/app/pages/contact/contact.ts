import { Component, OnInit, inject, signal } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ServiceApi } from '../../data/service-api';
import { siteConfig } from '../../site-config';

interface ServiceGroup {
  name: string;
  services: string[];
}

// Used when the service list can't be loaded from the server.
const fallbackGroups: ServiceGroup[] = [
  { name: '3D Printing', services: ['FDM Printing', 'Resin Printing', '3D Modelling', 'Prototyping', 'Printer Maintenance'] },
  { name: 'IT Support', services: ['Desktop PC Repair', 'Virus Removal', 'Network Setup', 'Data Recovery'] },
  { name: 'Software Development', services: ['Web Development', 'Custom Software', 'Database Design'] },
];

@Component({
  selector: 'app-contact',
  imports: [FormsModule],
  templateUrl: './contact.html',
  styleUrl: './contact.css',
})
export class Contact implements OnInit {
  private readonly api = inject(ServiceApi);
  private readonly route = inject(ActivatedRoute);

  protected readonly site = siteConfig;
  protected readonly groups = signal<ServiceGroup[]>(fallbackGroups);
  protected readonly opened = signal(false);

  protected model = {
    name: '',
    email: '',
    service: '',
    message: '',
  };

  ngOnInit() {
    this.model.service = this.route.snapshot.queryParamMap.get('service') ?? '';

    this.api.getCategories().subscribe({
      next: (categories) =>
        this.groups.set(categories.map((c) => ({ name: c.name, services: c.services.map((s) => s.name) }))),
      error: () => {
        // Keep the fallback list.
      },
    });
  }

  protected submit(form: NgForm) {
    if (form.invalid) {
      form.control.markAllAsTouched();
      return;
    }

    const subject = `Enquiry: ${this.model.service || 'General'}`;
    const body = [
      this.model.message,
      '',
      `Name: ${this.model.name}`,
      `Email: ${this.model.email}`,
      `Service: ${this.model.service || 'Not sure / general enquiry'}`,
    ].join('\n');

    window.location.href =
      `mailto:${this.site.email}?subject=${encodeURIComponent(subject)}&body=${encodeURIComponent(body)}`;
    this.opened.set(true);
  }
}
