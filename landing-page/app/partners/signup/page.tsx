'use client';

import { useState } from 'react';
import { useRouter } from 'next/navigation';
import Link from 'next/link';
import { Loader2 } from 'lucide-react';

export default function PartnerSignupPage() {
  const router = useRouter();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');
  const [success, setSuccess] = useState(false);

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    setLoading(true);
    setError('');

    const formData = new FormData(e.currentTarget);
    const data = {
      email: formData.get('email'),
      password: formData.get('password'),
      firstName: formData.get('firstName'),
      lastName: formData.get('lastName'),
      companyName: formData.get('companyName'),
      phone: formData.get('phone'),
      website: formData.get('website'),
      taxId: formData.get('taxId'),
    };

    try {
      const response = await fetch('/api/partners/apply', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(data),
      });

      const result = await response.json();

      if (!response.ok) {
        throw new Error(result.error || 'Application failed');
      }

      setSuccess(true);
      setTimeout(() => {
        router.push('/partners/login');
      }, 3000);
    } catch (err: any) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="min-h-screen bg-gradient-to-br from-slate-900 via-slate-800 to-slate-900 flex items-center justify-center px-4 py-12">
      <div className="max-w-2xl w-full">
        <div className="text-center mb-8">
          <h1 className="text-4xl font-bold text-white mb-4">Aplicar al Programa de Socios</h1>
          <p className="text-slate-300">Completa tu aplicación y comienza a ganar comisiones</p>
        </div>

        {success ? (
          <div className="bg-green-500/10 border border-green-500/20 rounded-xl p-8 text-center">
            <div className="text-4xl mb-4">✅</div>
            <h2 className="text-2xl font-bold text-white mb-2">¡Aplicación Enviada!</h2>
            <p className="text-slate-300">
              Revisaremos tu aplicación y te notificaremos por correo cuando sea aprobada.
              Redirigiendo al login...
            </p>
          </div>
        ) : (
          <form onSubmit={handleSubmit} className="bg-slate-800/50 border border-slate-700 rounded-xl p-8">
            {error && (
              <div className="mb-6 bg-red-500/10 border border-red-500/20 rounded-lg p-4">
                <p className="text-red-400">{error}</p>
              </div>
            )}

            <div className="grid md:grid-cols-2 gap-6 mb-6">
              <div>
                <label htmlFor="firstName" className="block text-sm font-medium text-slate-300 mb-2">
                  Nombre *
                </label>
                <input
                  type="text"
                  id="firstName"
                  name="firstName"
                  required
                  className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
                />
              </div>

              <div>
                <label htmlFor="lastName" className="block text-sm font-medium text-slate-300 mb-2">
                  Apellido *
                </label>
                <input
                  type="text"
                  id="lastName"
                  name="lastName"
                  required
                  className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
                />
              </div>
            </div>

            <div className="mb-6">
              <label htmlFor="email" className="block text-sm font-medium text-slate-300 mb-2">
                Email *
              </label>
              <input
                type="email"
                id="email"
                name="email"
                required
                className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
              />
            </div>

            <div className="mb-6">
              <label htmlFor="password" className="block text-sm font-medium text-slate-300 mb-2">
                Contraseña * (mínimo 8 caracteres)
              </label>
              <input
                type="password"
                id="password"
                name="password"
                required
                minLength={8}
                className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
              />
            </div>

            <div className="mb-6">
              <label htmlFor="companyName" className="block text-sm font-medium text-slate-300 mb-2">
                Nombre de la Empresa
              </label>
              <input
                type="text"
                id="companyName"
                name="companyName"
                className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
              />
            </div>

            <div className="grid md:grid-cols-2 gap-6 mb-6">
              <div>
                <label htmlFor="phone" className="block text-sm font-medium text-slate-300 mb-2">
                  Teléfono
                </label>
                <input
                  type="tel"
                  id="phone"
                  name="phone"
                  className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
                />
              </div>

              <div>
                <label htmlFor="taxId" className="block text-sm font-medium text-slate-300 mb-2">
                  RUC / Tax ID
                </label>
                <input
                  type="text"
                  id="taxId"
                  name="taxId"
                  className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
                />
              </div>
            </div>

            <div className="mb-6">
              <label htmlFor="website" className="block text-sm font-medium text-slate-300 mb-2">
                Sitio Web
              </label>
              <input
                type="url"
                id="website"
                name="website"
                placeholder="https://"
                className="w-full px-4 py-2 bg-slate-900 border border-slate-600 rounded-lg text-white focus:border-red-500 focus:outline-none"
              />
            </div>

            <button
              type="submit"
              disabled={loading}
              className="w-full px-8 py-4 bg-gradient-to-r from-red-500 to-orange-500 text-white rounded-lg font-semibold hover:shadow-lg hover:shadow-red-500/50 transition-all disabled:opacity-50 disabled:cursor-not-allowed flex items-center justify-center gap-2"
            >
              {loading ? (
                <>
                  <Loader2 className="w-5 h-5 animate-spin" />
                  Enviando...
                </>
              ) : (
                'Enviar Aplicación'
              )}
            </button>

            <p className="mt-4 text-center text-sm text-slate-400">
              ¿Ya tienes cuenta?{' '}
              <Link href="/partners/login" className="text-red-400 hover:text-red-300">
                Iniciar Sesión
              </Link>
            </p>
          </form>
        )}
      </div>
    </div>
  );
}
