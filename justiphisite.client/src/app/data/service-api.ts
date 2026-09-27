import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';

export interface ServiceItem {
  serviceID: number;
  name: string;
  description: string | null;
  price: number;
  serviceCategoryID: number;
}

export interface ServiceCategory {
  serviceCategoryID: number;
  name: string;
  services: ServiceItem[];
}

/** Turns a category name into a URL fragment, e.g. "3D Printing" -> "3d-printing". */
export function categorySlug(name: string): string {
  return name.toLowerCase().replace(/[^a-z0-9]+/g, '-').replace(/(^-|-$)/g, '');
}

@Injectable({ providedIn: 'root' })
export class ServiceApi {
  private readonly http = inject(HttpClient);

  getCategories(): Observable<ServiceCategory[]> {
    return this.http.get<ServiceCategory[]>('/api/service/categories');
  }
}
